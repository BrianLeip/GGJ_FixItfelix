﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterScript : MonoBehaviour
{
    //private float barDisplay;

    private Vector2 posMind;
    private Vector2 sizeMind;
    private float currentMindState;
    private float currentMindPos;

    private Vector2 posBody;
    private Vector2 sizeBody;
    private float currentBodyState;
    private float currentBodyPos;

    private Vector2 posSoul;
    private Vector2 sizeSoul;
    private float currentSoulState;
    private float currentSoulPos;

    public float newMindVal;
    public float newBodyVal;
    public float newSoulVal;
    public Texture2D progressBarEmpty;
    //public Texture2D progressBarFull;

    // Start is called before the first frame update
    void Start()
    {
        currentMindPos = 0.2f;
        currentMindState = 0.2f;
        posMind = new Vector2(Screen.width * currentMindPos, Screen.height * 0.8f);
        sizeMind = new Vector2(Screen.width * currentMindState, Screen.height * 0.1f);

        currentBodyPos = 0.4f;
        currentBodyState = 0.2f;
        posBody = new Vector2(Screen.width * currentBodyPos, Screen.height * 0.8f);
        sizeBody = new Vector2(Screen.width * currentBodyState, Screen.height * 0.1f);

        currentSoulPos = 0.599f;
        currentSoulState = 0.2f;
        posSoul = new Vector2(Screen.width * currentSoulPos, Screen.height * 0.8f);
        sizeSoul = new Vector2(Screen.width * currentSoulState, Screen.height * 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        //ChangeStateOfMind(newMindVal);
        //ChangeStateOfBody(newBodyVal);
        //ChangeStateOfSoul(newSoulVal);
    }

    void OnGUI()
    {

        //Mind bar
        GUI.BeginGroup(new Rect(posMind.x, posMind.y, sizeMind.x, sizeMind.y));
        GUI.Box(new Rect(0, 0, sizeMind.x, sizeMind.y), progressBarEmpty);
        GUI.EndGroup();

        //Body bar
        GUI.BeginGroup(new Rect(posBody.x, posBody.y, sizeBody.x, sizeBody.y));
        GUI.Box(new Rect(0, 0, sizeBody.x, sizeBody.y), progressBarEmpty);
        GUI.EndGroup();

        //Soul bar
        GUI.BeginGroup(new Rect(posSoul.x, posSoul.y, sizeSoul.x, sizeSoul.y));
        GUI.Box(new Rect(0, 0, sizeSoul.x, sizeSoul.y), progressBarEmpty);
        GUI.EndGroup();
    }

    public void MoveMindBar(float newMindPos)
    {
        currentMindPos -= newMindPos;
        posMind = new Vector2(Screen.width * currentMindPos, Screen.height * 0.8f);
        //sizeMind = new Vector2(Screen.width * currentMindState, Screen.height * 0.1f);
    }

    public void ChangeStateOfMind(float newMindState)
    {
        currentMindState += newMindState;
        sizeMind = new Vector2(Screen.width * currentMindState, Screen.height * 0.1f);
        MoveMindBar(newMindState);
    }

    public void ChangeStateOfBody(float newBodyState)
    {
        currentBodyState += newBodyState;
        float halfNewBodyState = newBodyState * 0.5f;
        currentBodyPos -= halfNewBodyState;

        posBody = new Vector2(Screen.width * currentBodyPos, Screen.height * 0.8f);
        sizeBody = new Vector2(Screen.width * currentBodyState, Screen.height * 0.1f);

        MoveMindBar(halfNewBodyState);
        MoveSoulBar(halfNewBodyState);
    }

    public void MoveSoulBar(float newSoulPos)
    {
        currentSoulPos += newSoulPos;
        posSoul = new Vector2(Screen.width * currentSoulPos, Screen.height * 0.8f);
    }

    public void ChangeStateOfSoul(float newSoulState)
    {
        currentSoulState += newSoulState;
        sizeSoul = new Vector2(Screen.width * currentSoulState, Screen.height * 0.1f);
    }
}
