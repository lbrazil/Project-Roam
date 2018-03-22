using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
//using TMPro;

public class AttractionVideoPlay : MonoBehaviour {

    //[SerializeField] GameObject videoObject;

    //bool videoPlaying = true;

    //private void Awake()
    //{
    //    GetComponent<Button>().onClick.AddListener(PlayVideo);
    //}

    //public void PlayVideo()
    //{
    //    if (transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "Stop Video")
    //    {
    //        videoObject.SetActive(false);
    //        GetComponent<VideoPlayer>().Stop();
    //        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Play Video";
    //    }
    //    else
    //    {
    //        videoObject.SetActive(true);
    //        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Stop Video";
    //        videoToPlay = Resources.Load("Video/" + AttractionController.Instance.AttractionName) as VideoClip;
    //        StartCoroutine(delay());
    //    }
    //}

    //public RawImage VideoScreen;

    //public VideoClip videoToPlay;

    //private VideoPlayer videoPlayer;
    //private VideoSource videoSource;

    //private AudioSource audioSource;

    ////void Start () {
    ////       Application.runInBackground = false;
    ////       StartCoroutine(playVideo());
    ////}

    //IEnumerator playVideo()
    //{
    //    videoPlayer = gameObject.GetComponent<VideoPlayer>();
    //    audioSource = gameObject.GetComponent<AudioSource>();

    //    videoPlayer.playOnAwake = false;
    //    audioSource.playOnAwake = false;
    //    audioSource.Pause();

    //    //videoPlayer.source = VideoSource.VideoClip;

    //    // Video clip from Url
    //    //videoPlayer.source = VideoSource.Url;
    //    //videoPlayer.url = "http://www.iflysingapore.com/wp-content/uploads/2015/07/iFly-Singapore-First-Time-flyer-experience.mp4";//"http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";


    //    //Set Audio Output to AudioSource
    //    videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

    //    //Assign the Audio from Video to AudioSource to be played
    //    videoPlayer.controlledAudioTrackCount = 1;
    //    videoPlayer.EnableAudioTrack(0, true);
    //    videoPlayer.SetTargetAudioSource(0, audioSource);

    //    //Set video To Play then prepare Audio to prevent Buffering
    //    videoPlayer.clip = videoToPlay;
    //    videoPlayer.Prepare();

    //    //Wait until video is prepared
    //    WaitForSeconds waitTime = new WaitForSeconds(1);
    //    while (!videoPlayer.isPrepared)
    //    {
    //        yield return waitTime;
    //        break;
    //    }

    //    Debug.Log("Done Preparing Video");

    //    //Assign the Texture from Video to RawImage to be displayed
    //    VideoScreen.texture = videoPlayer.texture;

    //    //Play Video
    //    videoPlayer.Play();

    //    //Play Sound
    //    audioSource.Play();

    //    Debug.Log("Playing Video");
    //    while (videoPlayer.isPlaying)
    //    {
    //        yield return null;
    //    }

    //    Debug.Log("Done Playing Video");
    //}

    ////private void OnEnable()
    ////{
    ////    StartCoroutine(delay());
    ////}

    //IEnumerator delay()
    //{
    //    Application.runInBackground = false;
    //    StartCoroutine(playVideo());
    //    yield return new WaitForSeconds(1);

    //    videoPlayer.Play();
    //    //videoPlayer.Stop();
    //}
}
