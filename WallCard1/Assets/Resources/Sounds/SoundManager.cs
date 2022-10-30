using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{ 
    private static GameObject[] objs;
    private void Awake()
    {
        objs = GameObject.FindGameObjectsWithTag("Sound");

        if (objs.Length > 1)
            Destroy(this.gameObject);

        objs[0].GetComponent<AudioSource>().Play();        
        DontDestroyOnLoad(this.gameObject);
    }

    public static void SoundStatus()
    {
        if (objs[0].GetComponent<AudioSource>().isPlaying)
            objs[0].GetComponent<AudioSource>().Pause();
        else if (!objs[0].GetComponent<AudioSource>().isPlaying)
            objs[0].GetComponent<AudioSource>().UnPause();
    }
}
