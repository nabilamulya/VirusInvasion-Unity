//Script Musuh 
var Darah = 1000;
var Musuh : GameObject;
var Jarak;
var Target : Transform;
var LRotation = 25.0;
var Range = 15.0;
var Speed = 10;
var Damping = 6.5;

function Update ()
{
	Jarak = Vector3.Distance(Target.position, transform.position);
	
	if (Jarak < LRotation)
	{
		Melihat();
	}
	
	if (Jarak < LRotation)
	{
		Kejar();
	}
	
	if(Darah <= 0)// Jika Darah Musuh Kurang Dari 0 Atau Sudah 0 Maka..
	{
		Mati();
	}
}

function ADarah(BDarah : int)
{
	Darah -= BDarah; 
}

function Mati ()
{
	Destroy(Musuh.gameObject);
}

function Melihat ()
{
	var rotation = Quaternion.LookRotation(Target.position - transform.position );
	transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
}

function Kejar ()
{
	transform.Translate(Vector3.forward * Speed * Time.deltaTime);
}