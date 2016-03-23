(function () {
    /**
     * @ngdoc function
     * @name weatherApp.controller:MainCtrl
     * @description
     * # MainCtrl
     * Controller of the weatherApp
     */

    'use strict';

    angular.module('weatherApp', [])
        .controller('MainCtrl', ['$scope', '$timeout', '$q', 'dataContext', function MainCtrl($scope, $timeout, $q, dataContext) {
            $scope.showCityList = false;
            $scope.$watch('country', function (tmpStr) {
                if (!tmpStr || tmpStr.length == 0)
                    return 0;
                $timeout(function () {
                    // if searchStr is still the same..
                    // go ahead and retrieve the data
                    if (tmpStr === $scope.country) {
                        $scope.error = false;
                        var promise = dataContext.getCities(tmpStr);
                        promise.success(function (data) {
                            $scope.cities = data;
                            $scope.showCityList = true;
                            $('#citySelect').focus();
                        })
                        .error(function (response, status) {
                            console.log(response);
                            console.log(status);
                            $scope.showCityList = false;
                            $scope.error = true;
                            if (response.Message) {
                                $scope.errorMessage = response.Message;
                            }
                            if (response.ExceptionType) {
                                $scope.detailErrorMessage = response.ExceptionType + ": " + response.ExceptionMessage;
                            }
                            if (status) {
                                $scope.detailErrorMessage = status;
                            }
                        });
                    }
                }, 1000);
            });


            $scope.populateWeather = function () {
                var promise = dataContext.getWeather($scope.selectedCity, $scope.country);
                promise.success(function (data) {
                    var statusKey = "Status";
                    if (data[statusKey] !== "Success") {
                        $scope.error = true;
                        $scope.errorMessage = "Error occured, please try again";
                        $scope.detailErrorMessage = "";
                    }
                    delete data[statusKey];

                    var weatherJson = [];
                    for (var i in data) {
                        weatherJson.push({ key: i, value: data[i] });
                    }
                    $scope.weather = weatherJson;
                })
                .error(function (response, status) {
                    $scope.error = true;
                    $scope.errorMessage = response.Message;
                    if (response.Message) {
                        $scope.errorMessage = response.Message;
                    }
                    if (response.ExceptionType) {
                        $scope.detailErrorMessage = response.ExceptionType + ": " + response.ExceptionMessage;
                    }
                    if (status) {
                        $scope.detailErrorMessage = status;
                    }
                });
            };
        }]);
})();



