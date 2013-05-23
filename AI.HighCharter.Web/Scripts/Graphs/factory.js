graphs.factory = function(domElement) {
    for (var type in graphs.types) {
        var handler = graphs.types[type]();
        if (handler.canHandle(domElement)) {
            return handler;
        }
    }
}