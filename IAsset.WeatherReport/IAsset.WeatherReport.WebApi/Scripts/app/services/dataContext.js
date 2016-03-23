(function () {

    'use strict';

    /**
     * @ngdoc service
     * @name weatherApp.dataContext
     * @description
     * # details
     * Factory in the weatherApp.
     */
    angular.module('weatherApp')
      .factory('dataContext', ['$http', '$location', function dataContext($http, $location) {
          var urlBase = $location.protocol() + "://" + location.host + "/weather/";
          return {
              // To fetch the list of cities for a country
              getCities:
                  function (country) {
                      var apiUrl = urlBase + "countries/" + country + "/cities";
                      return $http.get(apiUrl);
                  },
              // To fetch weather details based on City and Country
              getWeather: function (city, country) {
                  var apiUrl = urlBase + "cities/" + city + "/countries/" + country;
                  return $http.get(apiUrl);
              }
          }
      }]);
})();
