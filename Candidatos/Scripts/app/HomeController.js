angular.module("myApp").controller("HomeController", ["$scope", "$http", "$uibModal", function ($scope, $http, $uibModal) {

    $scope.processando = false;

    $scope.clean = function () {
        $scope.candidato = { Nome: "", Email: "", Html: "", Css: "", Django: "", Javascript: "", Python: "", Ios: "", Android: "" };
        $("#input-html").rating("clear");
        $("#input-css").rating("clear");
        $("#input-javascript").rating("clear");
        $("#input-python").rating("clear");
        $("#input-django").rating("clear");
        $("#input-ios").rating("clear");
        $("#input-android").rating("clear");
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
    var $modal = this;
    $modal.retorno = {};
    $modal.open = function () {
        $uibModal.open({
            templateUrl: 'Modal.html',
            controller: function ($scope) {
                $scope.retorno = $modal.retorno.data.Mensagem;
            }
        });
    };

    $scope.enviar = function () {
        $scope.processando = true;
        $scope.disabled();
        $http.post("/Home/Enviar", JSON.stringify($scope.candidato), {
            headers: {
                'Content-Type': "application/json"
            }
        })
            .then(function (data) {
                $modal.retorno = data;
                $scope.processando = false;
                $scope.disabled();
                $scope.clean();
                $modal.open();
            }, function (data) {
                $modal.retorno = data;
                $scope.processando = false;
                $scope.disabled();
                $modal.open();
            });
    }
}]);
