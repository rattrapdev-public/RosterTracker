
angular.module('rosterTrackerApp.services', []).
	service('rosterService', function($http) {
		this.rosterList = function() {
			return [
				{ name: 'John', email: 'john.doe@email.com' },
				{ name: 'Jane', email: 'jane.doe@email.com' }
			];
		};
	});