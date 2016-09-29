var fesco = fesco || {};
(function () {
    if (!moment || !moment.tz) {
        return;
    }

    /* DEFAULTS *************************************************/

    fesco.timing = fesco.timing || {};

    /* FUNCTIONS **************************************************/

    fesco.timing.convertToUserTimezone = function (date) {
        var momentDate = moment(date);
        var targetDate = momentDate.clone().tz(fesco.timing.timeZoneInfo.iana.timeZoneId);
        return targetDate;
    };

})();