namespace DemoStore.Controllers {

    export class HomeController {
        public productList;

        constructor(private $http: ng.IHttpService) {
            $http.get("/api/products")
                .then((response) => {
                    this.productList = response.data;
                })
                .catch((response) => {
                })
        }
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
