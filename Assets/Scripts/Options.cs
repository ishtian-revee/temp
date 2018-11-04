using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour {

    public AudioSource level01Music;    // A referrence to the level01 music
    public AudioSource level02Music;    // A referrence to the level01 music
    public AudioSource level03Music;    // A referrence to the level01 music

    // The method is called to set the music volume
    public void SetMusicVolume(float vol)
    {
        // Creating a menu music gameobject
        GameObject menuMusic = GameObject.Find("MenuMusic");    
        AudioSource menuAudio = menuMusic.GetComponent<AudioSource>();

        // Setting all the musics volume
        menuAudio.volume = vol;
        level01Music.volume = vol;
        level02Music.volume = vol;
        level03Music.volume = vol;
    }

    // The method is called whenever the Go Back To Main Menu button is clicked
    public void BackToMainMenu()
    {
        // Loading main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
