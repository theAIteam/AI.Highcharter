graphs.factory = function(domElement) {
    for (var type in graphs.types) {
        if ($(domElement).hasClass(type)) {
            var handler = graphs.types[type];
            return handler;
        }
    }
    return null;
}