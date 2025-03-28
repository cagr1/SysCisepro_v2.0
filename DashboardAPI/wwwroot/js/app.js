// js/app.js

// Responsive Sidebar Management

const sidebar = document.getElementById('sidebar');
const mainContent = document.getElementById('mainContent');
const sidebarToggle = document.getElementById('sidebarToggle');
const toggleIcon = document.getElementById('toggleIcon');
//const expandedMenu = document.getElementById('expandedMenu');

let isPinned = false;

sidebar.addEventListener('mouseenter', () => {
    if (!isPinned) {
        sidebar.classList.replace('w-20', 'w-64');
        mainContent.classList.replace('ml-20', 'ml-64');
    }
});



sidebar.addEventListener('mouseleave', () => {
    if (!isPinned) {
        sidebar.classList.replace('w-64', 'w-20');
        mainContent.classList.replace('ml-64', 'ml-20');
    }
});

// Toggle del sidebar
sidebarToggle.addEventListener('click', () => {
    isPinned = !isPinned;
    
    // Control de clases principales

   

    sidebar.classList.toggle('w-64', isPinned);
    sidebar.classList.toggle('w-20', !isPinned);
    mainContent.classList.toggle('ml-64', isPinned);
    mainContent.classList.toggle('ml-20', !isPinned);
    

   
    // Control de icono
    toggleIcon.innerHTML = isPinned ? 
    `<path d="M16.642 20.669c-0.391 0.39-0.391 1.023-0 1.414 0.195 0.195 0.451 0.293 0.707 0.293s0.512-0.098 0.707-0.293l5.907-6.063-5.907-6.063c-0.39-0.39-1.023-0.39-1.414 0s-0.391 1.024 0 1.414l3.617 3.617h-19.264c-0.552 0-1 0.448-1 1s0.448 1 1 1h19.326zM30.005 0h-18c-1.105 0-2.001 0.895-2.001 2v9h2.014v-7.78c0-0.668 0.542-1.21 1.21-1.21h15.522c0.669 0 1.21 0.542 1.21 1.21l0.032 25.572c0 0.668-0.541 1.21-1.21 1.21h-15.553c-0.668 0-1.21-0.542-1.21-1.21v-7.824l-2.014 0.003v9.030c0 1.105 0.896 2 2.001 2h18c1.105 0 2-0.895 2-2v-28c-0.001-1.105-0.896-2-2-2z"/>` :
    // SVG para estado "logged out" (ícono diferente)
    `<path d="M3.651 16.989h17.326c0.553 0 1-0.448 1-1s-0.447-1-1-1h-17.264l3.617-3.617c0.391-0.39 0.391-1.024 0-1.414s-1.024-0.39-1.414 0l-5.907 6.062 5.907 6.063c0.196 0.195 0.451 0.293 0.707 0.293s0.511-0.098 0.707-0.293c0.391-0.39 0.391-1.023 0-1.414zM29.989 0h-17c-1.105 0-2 0.895-2 2v9h2.013v-7.78c0-0.668 0.542-1.21 1.21-1.21h14.523c0.669 0 1.21 0.542 1.21 1.21l0.032 25.572c0 0.668-0.541 1.21-1.21 1.21h-14.553c-0.668 0-1.21-0.542-1.21-1.21v-7.824l-2.013 0.003v9.030c0 1.105 0.895 2 2 2h16.999c1.105 0 2.001-0.895 2.001-2v-28c-0-1.105-0.896-2-2-2z"/>`;

    sidebar.classList.toggle('pinned', isPinned);
});








function formatDateWithTime(dateString, isEndDate = false, subtractYear = false) {
    const date = new Date(dateString + 'T00:00:00Z'); // Asegurarse de que la fecha esté en UTC
    
    if (subtractYear) {
        date.setFullYear(date.getFullYear() - 1);
    }

    if (isEndDate) {
        date.setUTCHours(23, 59, 59);
    } else {
        date.setUTCHours(0, 0, 0);
    }
    
    return date.toISOString().slice(0, 19).replace('T', ' ');
}

function returnYearfromDatepiker() {
    
        const dateInput = document.getElementById('startDate').value;
        const year = document.getElementById('yearCardActualIncomes');
        const prevoiusYear = document.getElementById('yearCardPreviousIncomes');
        
        if (dateInput && year && prevoiusYear) {
            const date = new Date(dateInput + 'T00:00:00Z'); // Asegurarse de que la fecha esté en UTC
            const dateYear = date.getUTCFullYear(); // Obtener el año en UTC
            const beforeYear = dateYear - 1; // Calcular el año anterior
            year.textContent = dateYear;
            prevoiusYear.textContent = beforeYear; // Actualizar el año anterior
        }
   
}
document.getElementById('startDate').addEventListener('change', returnYearfromDatepiker);


// Configurar fechas iniciales (año actual)
function setDefaultDates() {
    const currentYear = new Date().getFullYear();
    const defaultStart = `${currentYear}-01-01`;
    const defaultEnd = `${currentYear}-12-31`;
    
    document.getElementById('startDate').value = defaultStart;
    document.getElementById('endDate').value = defaultEnd;
}

async function loadData() {
    
    // Obtener fechas de los inputs        
    const startDateInput = document.getElementById('startDate').value;
    const endDateInput = document.getElementById('endDate').value;
    
    // Agregar tiempos automáticamente
    const startDate = formatDateWithTime(startDateInput);
    const endDate = formatDateWithTime(endDateInput, true);

    const previousStartDate = formatDateWithTime(startDateInput, false, true);
    const previousEndDate = formatDateWithTime(endDateInput, true, true);

    try {
        // Obtener datos de la API
        const ventasUrl = `http://localhost:5179/api/Dashboard/sales/by-date?startDate=${encodeURIComponent(startDate)}&endDate=${encodeURIComponent(endDate)}`;
        const acumuladoUrl = `http://localhost:5179/api/Dashboard/sales/accumulated?endDate=${encodeURIComponent(endDate)}`;
        const ventasPreviousUrl = `http://localhost:5179/api/Dashboard/sales/by-date?startDate=${encodeURIComponent(previousStartDate)}&endDate=${encodeURIComponent(previousEndDate)}`;
        const ventasPreviousAcumuladoUrl = `http://localhost:5179/api/Dashboard/sales/accumulated?endDate=${encodeURIComponent(previousEndDate)}`;

        const [ventasResponse, acumuladoResponse, ventasPreviousResponse, ventasPreviousAcumuladoResponse ] = await Promise.all([
            fetch(ventasUrl),
            fetch(acumuladoUrl),
            fetch(ventasPreviousUrl),
            fetch(ventasPreviousAcumuladoUrl)
        ]);
        
        

        if (!ventasResponse.ok) throw new Error(`Error ventas: ${ventasResponse.status}`);
        if (!acumuladoResponse.ok) throw new Error(`Error acumulado: ${acumuladoResponse.status}`);
        if (!ventasPreviousResponse.ok) throw new Error(`Error ventas anteriores: ${ventasPreviousResponse.status}`);
        if (!ventasPreviousAcumuladoResponse.ok) throw new Error(`Error acumulado anterior: ${ventasPreviousAcumuladoResponse.status}`);

        const ventasData = await ventasResponse.json();
        const acumuladoData = await acumuladoResponse.json();
        const ventasPreviousData = await ventasPreviousResponse.json();
        const acumuladoPreviousData = await ventasPreviousAcumuladoResponse.json();

        
        // 5. Actualizar la UI con los datos
        updateStats(ventasData, acumuladoData, ventasPreviousData, acumuladoPreviousData);
        
    } catch (error) {
        console.error('Error:', error);
        alert('Error al cargar los datos');
    }
}

// Actualizar estadísticas
function updateStats(ventas, acumulado,ventasPrevious, acumuladoPrevious) {
    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency',
        currency: 'USD'
    });

    document.getElementById('ventasRango').textContent = formatter.format(ventas.totalSales);
    document.getElementById('ventasAcumuladas').textContent = formatter.format(acumulado.totalSales) + ' acumulado';
    document.getElementById('ventasRangoPrevious').textContent = formatter.format(ventasPrevious.totalSales);
    document.getElementById('ventasAcumuladasPrevious').textContent = formatter.format(acumuladoPrevious.totalSales) + ' acumulado';
}

// Cargar datos iniciales
document.addEventListener('DOMContentLoaded', () => {
    setDefaultDates(); 
    loadData();
    manageSidebar();
    window.addEventListener('resize', manageSidebar);
});