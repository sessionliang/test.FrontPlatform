define(function () {
    return {
        load: function (name, req, onload, config) {
            var url = fesco.appPath + 'api/fescoServiceProxies/Get?name=' + name;
            req([url], function (value) {
                onload(value);
            });
        }
    };
});