/*Since Chrome often ignores the autocomplete="off" or autocomplete="false" directive, I researched and found a workaround to preven the autofill dropdown from covering the 
custom-built dropdown. */

	function DisableAutoComplete() {
		var thisInput = document.getElementById('campaignReview');
		thisInput.setAttribute('autocomplete', 'off');
	}

	DisableAutoComplete();
