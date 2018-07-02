var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('Tian');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);