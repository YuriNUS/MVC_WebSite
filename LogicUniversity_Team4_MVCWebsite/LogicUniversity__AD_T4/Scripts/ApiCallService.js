angular.module('LogicuniversityApp', ['ngSanitize', 'ui.select', 'ngTable', 'ngResource']).config(function ($httpProvider) {
    $httpProvider.defaults.headers.common = {};
    $httpProvider.defaults.headers.post = {};
    $httpProvider.defaults.headers.put = {};
    $httpProvider.defaults.headers.patch = {};
});
angular.module('LogicuniversityApp', ['ngSanitize', 'ui.select', 'ngTable', 'ngResource']).service('ApiCall',
['$http', function ($http) {
   
    var url = "http://172.23.134.35/MyApi/api/";
        var result;
        this.GetApiCall = function(controllername, methodname) {
            result = $http.get(url + controllername + '/' + methodname);
               
            return result;
        };
        this.ApiPut=function(controllername, methodname,obj) {
            result = {
                method: "Delete",
                url: url + controllername + '/' + methodname+'/'+obj
            
            }
            $http(result);
           
        }
       
    }]);