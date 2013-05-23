graphs.types.line = function() {
    var that = {};
    var self = this;

    that.canHandle = function(domElement) {
        if ($(domElement).hasClass('line')) {
            self.domElement = domElement;
            return true;
        }
        return false;
    };

    that.modifyChart = function(chart) {
        chart.chart = { type: 'line' };
        return chart;
    };

    return that;
};