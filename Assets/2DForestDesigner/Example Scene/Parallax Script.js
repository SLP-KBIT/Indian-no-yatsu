#pragma strict

var speedX : float = 1;
var speedY : float = 1;
private var offsetX : float;
private var offsetY : float;

function Start (){
	offsetX = gameObject.transform.position.x;
	if (speedY == 0){
		offsetY = gameObject.transform.position.y - Camera.main.transform.position.y;
	} else {
		offsetY = gameObject.transform.position.y;
	}
	
}
function Update () {

	gameObject.transform.position.x = -Camera.main.transform.position.x * speedX + offsetX;
	if (speedY == 0){
		gameObject.transform.position.y = Camera.main.transform.position.y + offsetY;
	} else {
		gameObject.transform.position.y = -Camera.main.transform.position.y * speedY + offsetY;
	}
}