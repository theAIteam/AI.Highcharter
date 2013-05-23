graphs.types.column = function () {
    var that = {};
    var self = this;

    that.canHandle = function (domElement) {
        if ($(domElement).hasClass('column')) {
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

        chart.chart = { type: 'column', zoomType: 'x' };
        chart.plotOptions = plotOptions;

        return chart;
    };
    return that;
};
