﻿using UnityEngine;
using UnityEngine.Advertisements;

public class PlayUnityAdsHelper : MonoBehaviour
{
    private const string android_game_id = "3933763";
    private const string ios_game_id = "3933762";

    private const string rewarded_video_id = "rewardedVideo";
    GameOver gameOver;
    PlayCounter playCounter;
    void Start()
    {
        Initialize();
        gameOver = GameObject.Find("Player").GetComponent<GameOver>();
        playCounter = GameObject.Find("Counter").GetComponent<PlayCounter>();
    }

    private void Initialize()
    {
#if UNITY_ANDROID
        Advertisement.Initialize(android_game_id);
#elif UNITY_IOS
        Advertisement.Initialize(ios_game_id);
#endif
    }

    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady(rewarded_video_id))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };

            Advertisement.Show(rewarded_video_id, options);
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                {
                    Debug.Log("The ad was successfully shown.");

                    // to do ...
                    // 광고 시청이 완료되었을 때 처리
                    playCounter.Setting();
             
                    GameOver.isEnter = false;
                    gameOver.gameOverImge.gameObject.SetActive(false);
                    AudioSource BGMSound = gameOver.BGMStop.GetComponent<AudioSource>();
                    BGMSound.Play();
                    break;
                }
            case ShowResult.Skipped:
                {
                    Debug.Log("The ad was skipped before reaching the end.");

                    // to do ...
                    // 광고가 스킵되었을 때 처리

                    break;
                }
            case ShowResult.Failed:
                {
                    Debug.LogError("The ad failed to be shown.");

                    // to do ...
                    // 광고 시청에 실패했을 때 처리

                    break;
                }
        }
    }
}