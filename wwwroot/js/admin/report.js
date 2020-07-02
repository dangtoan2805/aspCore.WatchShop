$(function () {
    /*======== VARIABLE========*/
    var ar = [
        100,
        11000,
        10000,
        14000,
        11000,
        17000,
        14500,
        18000,
        5000,
        23000,
        14000,
        19000,
        100,
        11000,
        10000,
        14000,
        11000,
        17000,
        14500,
        18000,
        5000,
        23000,
        14000,
        19000,
        14500,
        18000,
        5000,
        23000,
        14000,
        19000

    ]
    //Date defautl
    var start = moment().subtract(6, 'days');
    var end = moment();
    /*======== DEFINE EVENT ON VIEW ========*/
    var onChangeDate = function (start, end) {
        $('#reportrange span').html(start.format(dateFormter) + ' - ' + end.format(dateFormter));
        getReport(start, end);
    }

    /*======== GET DATA ========*/
    function getReport(fromDate, toDate) {
        $.ajax({
            method: "GET",
            url: `/Admin/Home/OrderReport`,
            dataType: "JSON",
            data: { start: fromDate.format(dateFormter), end: toDate.format(dateFormter) }
        }).done(data => {
            displayReport(getDays(fromDate, toDate), ar);
            $("#vt-orders").text(1000);
            $("#vt-revenue").text(99999);
        })
    }

    /*======== ATTACH EVENT ========*/
    $('#reportrange').daterangepicker({
        startDate: start,
        endDate: end,
        ranges: {
            'Last 7 Days': [moment().subtract(6, 'days'), moment()],
            'Last 30 Days': [moment().subtract(29, 'days'), moment()],
            'This Month': [moment().startOf('month'), moment().endOf('month')],
            'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
        }
    }, onChangeDate);


    /*======== UPDATE VIEW ========*/
    // Display on View
    function displayReport(lables, data) {
        var lineChart = document.createElement('canvas');
        lineChart.classList.add('chartjs');
        $('#chart-content').empty();
        $('#chart-content').append(lineChart);
        if (lineChart !== null) {
            var chart = new Chart(lineChart, {
                // The type of chart we want to create
                type: "line",
                // The data for our dataset
                data: {
                    labels: lables,
                    datasets: [
                        {
                            label: "",
                            backgroundColor: "transparent",
                            borderColor: "rgb(82, 136, 255)",
                            data: data,
                            lineTension: 0.3,
                            pointRadius: 5,
                            pointBackgroundColor: "rgba(255,255,255,1)",
                            pointHoverBackgroundColor: "rgba(255,255,255,1)",
                            pointBorderWidth: 2,
                            pointHoverRadius: 8,
                            pointHoverBorderWidth: 1
                        },
                    ]
                },
                // Configuration options go here
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    legend: {
                        display: false
                    },
                    layout: {
                        padding: {
                            right: 10
                        }
                    },
                    scales: {
                        xAxes: [
                            {
                                gridLines: {
                                    display: false
                                }
                            }
                        ],
                        yAxes: [
                            {
                                gridLines: {
                                    display: true,
                                    color: "#eee",
                                    zeroLineColor: "#eee",
                                }
                            }
                        ]
                    },
                    tooltips: {
                        callbacks: {
                            title: function (tooltipItem, data) {
                                return data["labels"][tooltipItem[0]["index"]];
                            },
                            label: function (tooltipItem, data) {
                                return "$" + data["datasets"][0]["data"][tooltipItem["index"]];
                            }
                        },
                        responsive: true,
                        intersect: false,
                        enabled: true,
                        titleFontColor: "#888",
                        bodyFontColor: "#555",
                        titleFontSize: 10,
                        bodyFontSize: 18,
                        backgroundColor: "rgba(256,256,256,0.95)",
                        xPadding: 20,
                        yPadding: 10,
                        displayColors: false,
                        borderColor: "rgba(220, 220, 220, 0.9)",
                        borderWidth: 2,
                        caretSize: 10,
                        caretPadding: 15
                    }
                }
            });
        }
    }

    // Get List Day in Period  to show report
    function getDays(start, end) {
        let lables = []
        let fromDate = start;
        let toDate = end;
        do {
            lables.push(fromDate.format('DD/MM'));
            fromDate = fromDate.add(1, 'days');
            if (fromDate.format('DD/MM') === toDate.format('DD/MM')) {
                lables.push(fromDate.format('DD/MM'));
                break;
            }
        } while (true)
        return lables;
    }

    onChangeDate(start, end);
    /*======== END  ========*/
    $("#loading").fadeOut(500);
});