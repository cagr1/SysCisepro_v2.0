// js/app.js

function formatDateWithTime(dateString, isEndDate = false) {
    const date = new Date(dateString);
    
    if (isEndDate) {
        date.setHours(23, 59, 59);
    } else {
        date.setHours(0, 0, 0);
    }
    
    return date.toISOString().slice(0, 19).replace('T', ' ');
}

// Configurar fechas iniciales (año actual)
function setDefaultDates() {
    const currentYear = new Date().getFullYear();
    const defaultStart = `${currentYear}-01-01`;
    const defaultEnd = `${currentYear}-12-31`;
    
    document.getElementById('startDate').value = defaultStart;
    document.getElementById('endDate').value = defaultEnd;
}

async function loadData() {
    const startDateInput = document.getElementById('startDate').value;
    const endDateInput = document.getElementById('endDate').value;
    
    // Agregar tiempos automáticamente
    const startDate = formatDateWithTime(startDateInput);
    const endDate = formatDateWithTime(endDateInput, true);

    try {
        // Obtener datos de la API
        const ventasUrl = `http://localhost:5179/api/Dashboard/sales/by-date?startDate=${encodeURIComponent(startDate)}&endDate=${encodeURIComponent(endDate)}`;
        const acumuladoUrl = `http://localhost:5179/api/Dashboard/sales/accumulated?endDate=${encodeURIComponent(endDate)}`;

       
        const [ventasResponse, acumuladoResponse] = await Promise.all([
            fetch(ventasUrl),
            fetch(acumuladoUrl)
        ]);
        
        

        if (!ventasResponse.ok) throw new Error(`Error ventas: ${ventasResponse.status}`);
        if (!acumuladoResponse.ok) throw new Error(`Error acumulado: ${acumuladoResponse.status}`);

        const ventasData = await ventasResponse.json();
        const acumuladoData = await acumuladoResponse.json();

        
        // 5. Actualizar la UI con los datos
        updateStats(ventasData, acumuladoData);
        
    } catch (error) {
        console.error('Error:', error);
        alert('Error al cargar los datos');
    }
}

// Actualizar estadísticas
function updateStats(ventas, acumulado) {
    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency',
        currency: 'USD'
    });

    document.getElementById('ventasRango').textContent = formatter.format(ventas.totalSales);
    document.getElementById('ventasAcumuladas').textContent = formatter.format(acumulado.totalSales);
}

// Cargar datos iniciales
document.addEventListener('DOMContentLoaded', () => {
    setDefaultDates(); 
    loadData();
});