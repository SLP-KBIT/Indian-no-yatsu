#pragma strict

var rotationMax 	: float = 5;
var rotationMin 	: float = -5;
var rotationSpeed 	: float = 2;
var randomize 		: boolean = true;

private var rotateRight 		: boolean = true;
private var initRotationMax		: float;
private var initRotationMin		: float;
private var initRotationSpeed	: float;

function Start(){
	rotationMax = rotationMax/100;
	rotationMin = rotationMin/100;
	initRotationMax		= rotationMax;
	initRotationMin		= rotationMin;
	initRotationSpeed	= rotationSpeed;
	if (randomize){
		rotationSpeed 	= Random.Range( 0.2, initRotationSpeed*2 );
	}
	if (randomize && Random.value>0.5){
		rotateRight = false;
	}
}

function Update () {
	if ( rotateRight ){
		transform.Rotate( 0, 0, rotationSpeed*Time.deltaTime );
	} else {
		transform.Rotate( 0, 0, -rotationSpeed*Time.deltaTime );
	}
	if ( gameObject.transform.localRotation.z > rotationMax ){
		if (randomize){
			rotationSpeed 	= Random.Range( 0.2, initRotationSpeed*2 );
			rotationMin 	= Random.Range( 0, initRotationMin );
		}
		rotateRight = false;
	}
	if ( gameObject.transform.localRotation.z < rotationMin ){
		if (randomize){
			rotationSpeed 	= Random.Range( 0.2, initRotationSpeed*2 );
			rotationMax 	= Random.Range( 0, initRotationMax );
		}
		rotateRight = true;
	}
	// Debug.Log(gameObject.transform.localRotation.z);
}