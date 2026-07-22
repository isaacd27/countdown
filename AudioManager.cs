using System;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    [SerializeField] static AudioSource SFXsource;

    #region Player Variables
    public static AudioClip playerJump;
    public static AudioClip playerMove;
    public static AudioClip playerShoot1;


    public static AudioClip checkpoi;
    #endregion

    #region Environment Variables
    public static AudioClip gameOver;
    public static AudioClip zombiebite;



   // public static AudioClip Break;
    public static AudioClip respawn;

    #endregion


    void Start()
    {
        playerJump = Resources.Load<AudioClip>("jump");

        

        gameOver = Resources.Load<AudioClip>("Death_sfx");

        //Break = Resources.Load<AudioClip>("ConcreteBreak_sfx");

    
        checkpoi = Resources.Load<AudioClip>("CheckPoint");
        //Spong = Resources.Load<AudioClip>("Sponge_sfx");



        SFXsource = GetComponent<AudioSource>();

        //currentlanechange = Ensureplayed();
        // StartCoroutine(currentlanechange);


    }

    public static void playSFX(String clip)
    {
        switch (clip)
        {
            case "Jump":
            case "playerJump":

                SFXsource.PlayOneShot(playerJump);
                break;

            case "checkpoint":
            case "Checkpoint":
                SFXsource.PlayOneShot(checkpoi);
                break;


        

            case "Death":
            case "gameOver":
            case "kill":

                SFXsource.PlayOneShot(gameOver);

                break;

            

        

        }




        //SFXsource.PlayOneShot(clip);
    }

//the below can in theory load any audioclip or ,mp3 in the resources folder, good for testing purposes.
    public static void playbystring(String clip)
    {
        SFXsource.PlayOneShot(Resources.Load<AudioClip>(clip));
    }



    public void stopSFX()
    {
        SFXsource.Pause();
    }

    public void resumeSFX()
    {
        SFXsource.UnPause();
    }
}