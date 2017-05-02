angular.module("myApp").controller("HomeController", ["$scope", "$http", "$uibModal", function ($scope, $http, $uibModal) {

    $scope.processando = false;

    $scope.clean = function () {
        $("#input-html").rating("clear");
        $("#input-css").rating("clear");
        $("#input-javascript").rating("clear");
        $("#input-python").rating("clear");
        $("#input-django").rating("clear");
        $("#input-ios").rating("clear");
        $("#input-android").rating("clear");
        $scope.candidato = {};
    }
    $scope.disabled = function () {
        $("#input-html").rating("refresh", { disabled: $scope.processando, showClear: false });
        $("#input-css").rating("refresh", { disabled: $scope.processando, showClear: false });
        $("#input-javascript").rating("refresh", { disabled: $scope.processando, showClear: false });
        $("#input-python").rating("refresh", { disabled: $scope.processando, showClear: false });
        $("#input-django").rating("refresh", { disabled: $scope.processando, showClear: false });
        $("#input-ios").rating("refresh", { disabled: $scope.processando, showClear: false });
        $("#input-android").rating("refresh", { disabled: $scope.processando, showClear: false });
    }

    $scope.enviar = function () {
        $scope.processando = true;
        $scope.success = false;
        $scope.mensagem = "";
        $scope.disabled();
        $http.post("/Api/Candidato/", $scope.candidato, {
        })
            .then(function (data) {
                $scope.mensagem = "Parabéns sua candidatura foi realizada com sucesso!";
                $scope.success = true;
                $scope.processando = false;
                $scope.disabled();
                $scope.clean();
            }, function (data) {
                $scope.success = false;
                $scope.mensagem = data.data.Message;
                $scope.processando = false;
                $scope.disabled();
            });
    }
}]);
