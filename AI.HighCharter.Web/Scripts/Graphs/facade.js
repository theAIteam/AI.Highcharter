graphs.bind = function (container) {
    $(container).find('.chart').each(function (index, data) {
        var domElement = $(data);
        var url = "";
        var title = "";

        if (utilities.data.hasDataAttribute(domElement, 'title')) {
            title += utilities.data.getDataAttribute(domElement, 'title');
        }

        if (utilities.data.hasDataAttribute(domElement, 'url')) {
            url += utilities.data.getDataAttribute(domElement, 'url');
        }

        var chart = {
            title: { text: title },
            yAxis: { title: null },
        };

        if (url != "") {
            $.getJSON(url, function (chartData) {
                chart.xAxis = { categories: chartData.Categories };
                chart.series = chartData.Series;
                var handler = graphs.factory(domElement);
                chart = handler.modifyChart(chart);
                $(domElement).highcharts(chart);
            });
        }

    });
};


$(function () {
    graphs.bind($('body'));
})