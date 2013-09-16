graphs.types.bar = function(domElement, chart) {
    var plotOptions = {
        column: {
            pointPadding: 0,
            borderWidth: 0
        }
    };

    if ($(domElement).hasClass('stacked')) {
        plotOptions.series = {
            stacking: "normal"
        };
    }

    chart.chart = { type: 'bar' };
    chart.plotOptions = plotOptions;


    return chart;
};
