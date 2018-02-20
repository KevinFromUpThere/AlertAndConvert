/* 
    File: addToPlaylist.js
     
*/ 


var	iTunesApp = WScript.CreateObject("iTunes.Application");
var	mainLibrary = iTunesApp.LibraryPlaylist;
var	mainLibrarySource = iTunesApp.LibrarySource;

// get all playlists
var playlists = mainLibrarySource.Playlists;

var playlistStr = "Library"; // default to library if no library is supplied
var file;

if(WScript.Arguments.length == 2){
    file = WScript.Arguments(0);
    playlistStr = WScript.Arguments(1);
}else if(WScript.Arguments.length == 1){
    file =  WScript.Arguments(0);
}else{
    WScript.Echo("Please supply the file name as an argument");
}


// loop through playlists
for (i = 1; i <= playlists.count; i++)
{
	var	playlist = playlists.Item(i);
    if(playlist.name == playlistStr)
    {
        playlist.AddFile(file);
    }

}