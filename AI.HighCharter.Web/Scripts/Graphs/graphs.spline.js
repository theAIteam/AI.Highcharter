graphs.types.spline = function () {
    var that = {};
    var self = this;

    that.canHandle = function (domElement) {
        if ($(domElement).hasClass('spline')) {
            self.domElement = domElement;
            return true;
        }
        return false;
    };

    that.modifyChart = function (chart) {
        chart.chart = { type: 'spline' };
        return chart;
    };

    return that;
};