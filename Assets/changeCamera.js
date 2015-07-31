#pragma strict

function Start () {

}

var overview : Camera; 
var camera2 : Camera;
var camera3 : Camera;
var topview : Camera;
//var buttonTexture:Texture;
var customButton : GUIStyle;


   
function OnGUI () {
 	
 //	if(GUI.Button(Rect(10,10,50,50),buttonTexture));
 	//GUI.backgroundColor = new Color(0,0,0,0);
 	//GUILayout.Width (200)
    if (GUILayout.Button ("overview",customButton)) {
        overview.enabled = true; 
        camera2.enabled = false;
        camera3.enabled = false;
        topview.enabled = false;            
        }
 
    if (GUILayout.Button ("Camera2",customButton)) {
        camera2.enabled = true; 
        overview.enabled = false;
        camera3.enabled = false;
        topview.enabled = false;              
        }

    if (GUILayout.Button ("Camera3",customButton)) {
        camera3.enabled = true; 
        overview.enabled = false;
        camera2.enabled = false;
        topview.enabled = false;           
        } 
        	
    if (GUILayout.Button ("topview",customButton)) {
        topview.enabled = true; 
        overview.enabled = false;
        camera2.enabled = false;
        camera3.enabled = false;           
        }    
}


function Update () {

}