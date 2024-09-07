document.addEventListener('DOMContentLoaded', function () {
    var ctxInadimplencia = document.getElementById('inadimplenciaChart').getContext('2d');
    var ctxReceita = document.getElementById('receitaChart').getContext('2d');

    var inadimplenciaChart = new Chart(ctxInadimplencia, {
        type: 'line',
        data: {
            labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
            datasets: [{
                label: 'Evolução da Inadimplência',
                data: [0, 10, 5, 2, 20, 30],
                borderColor: 'rgba(255, 99, 132, 1)',
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });

    var receitaChart = new Chart(ctxReceita, {
        type: 'line',
        data: {
            labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
            datasets: [{
                label: 'Evolução da Receita',
                data: [0, 20, 10, 5, 15, 25],
                borderColor: 'rgba(54, 162, 235, 1)',
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
});
