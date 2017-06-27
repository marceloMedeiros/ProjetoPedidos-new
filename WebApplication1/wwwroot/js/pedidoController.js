(function () {

    "use strict";

    angular.module("pedido-index")
        .controller("pedidoController", pedidoController);

    function pedidoController() {

        var vm = this;

        vm.itensPH = [{
                ProdutoId: 1,
                Produto: "Bicicleta - Mock Data",
                Quantidade: 1,
                Valor: 500,
                ValorTotal: 500,
        },
        {
                ProdutoId: 2,
                Produto: "Bola - Mock Data",
                Quantidade: 2,
                Valor: 40,
                ValorTotal: 80,

        }];

        vm.itens = {};

        vm.a = function () {
            alert(vm.itens.Produto); 


            //$http.post("/api/Pedidos", vm.novoItem)
            //    .then(function (response) {
            //        // success
            //        vm.Pedidos.push(response.data);
            //        vm.novoItem = {};
            //    }, function () {
            //        // failure
            //        vm.errorMessage = "Failed to save";
            //    })
            //    .finally(function () {
            //        vm.isBusy = false;
            //    });

        };

        

    }

    
})();