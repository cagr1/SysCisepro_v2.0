// js/charts.js
let salesChart, accumulatedChart;

function initCharts() {
    // Gráfico de Ventas
    salesChart = new ApexCharts(document.querySelector("#chartSales"), {
        chart: { type: 'bar', height: 350 },
        series: [{ name: 'Ventas', data: [] }],
        xaxis: { type: 'category' },
        colors: ['#3B82F6']
    });
    salesChart.render();

    // Gráfico Acumulado
    accumulatedChart = new ApexCharts(document.querySelector("#chartAccumulated"), {
        chart: { type: 'line', height: 350 },
        series: [{ name: 'Acumulado', data: [] }],
        xaxis: { type: 'category' },
        colors: ['#10B981']
    });
    accumulatedChart.render();
}

// Llamar al inicializador
document.addEventListener('DOMContentLoaded', initCharts);