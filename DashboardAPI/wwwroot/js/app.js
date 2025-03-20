// js/app.js
async function loadData() {
    const startYear = document.getElementById('startYear').value || 2020;
    const endYear = document.getElementById('endYear').value || 2023;
    
    try {
        // Fetch data from API
        const [salesData, accumulatedData] = await Promise.all([
            fetch(`http://localhost:5179/api/Dashboard/sales/yearly?startYear=${startYear}&endYear=${endYear}`).then(res => res.json()),
            fetch(`http://localhost:5179/api/Dashboard/sales/accumulated?startYear=${startYear}&endYear=${endYear}`).then(res => res.json())
        ]);
        if (!salesResponse.ok || !accumulatedResponse.ok) {
            throw new Error('Error en la respuesta del servidor');
        }

        const salesData = await salesResponse.json();
        const accumulatedData = await accumulatedResponse.json();
        // Actualizar gráficos
        updateCharts(salesData, accumulatedData);
        
    } catch (error) {
        console.error('Error:', error);
        alert('Error al cargar datos');
    }
}

function updateCharts(sales, accumulated) {
    // Procesar datos para ApexCharts
    const salesSeries = sales.map(item => item.sales);
    const categories = sales.map(item => item.year);
    
    const accumulatedSeries = accumulated.map(item => item.acumulatedSales);

    // Actualizar gráficos
    salesChart.updateOptions({
        xaxis: { categories },
        series: [{ data: salesSeries }]
    });

    accumulatedChart.updateOptions({
        xaxis: { categories },
        series: [{ data: accumulatedSeries }]
    });
}

// Cargar datos iniciales
window.onload = () => loadData();