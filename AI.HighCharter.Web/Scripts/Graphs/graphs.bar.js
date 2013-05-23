graphs.types.bar = function () {
    var that = {};
    var self = this;

    that.canHandle = function (domElement) {
        if ($(domElement).hasClass('bar')) {
            self.domElement = domElement;
            return true;
        }
        return false;
    };


    that.modifyChart = function(chart) {
        var plotOptions = {
            column: {
                pointPadding: 0,
                borderWidth: 0
            }
        };

        if ($(self.domElement).hasClass('stacked')) {
            plotOptions.series = {
                stacking: "normal"
            };
        }

        chart.chart = { type: 'bar' };
        chart.plotOptions = plotOptions;
        

        return chart;
    };

    return that;
};
