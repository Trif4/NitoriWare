﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NitorInc.Utility;

namespace NitorInc.MarisaJizou {

    public class MarisaJizouMarisaController : MonoBehaviour {

        public float leftBound;
        public float rightBound;
        public float moveSpeed = 5.0f;
        public float finishSpeed = 10.0f;

        public Transform kasaSnapPoint;
        public GameObject kasaProto;
        public List<GameObject> kasaStack;

        bool hasTurned = false;

        public int dropLimit = 3;
        int dropCounter = 0;

        public float upMagnitude = 1.7f;

        public SpriteRenderer marisaSprite;
        Vector3 direction = Vector3.right;

        public delegate void OnAction();
        public static event OnAction onTurning;

        // Use this for initialization
        void Start() {
        }

        // Update is called once per frame
        void Update() {
            if (!MicrogameController.instance.getVictoryDetermined()) {
                
                transform.Translate(direction * moveSpeed * Time.deltaTime);

                if (transform.position.x <= leftBound || transform.position.x >= rightBound) {
                    if (!hasTurned) {
                        //transform.Rotate(Vector3.up, 180.0f);
                        marisaSprite.flipX = !marisaSprite.flipX;
                        direction *= -1.0f;
                        hasTurned = true;
                        if (onTurning != null)
                            onTurning();
                    }
                } else {
                    hasTurned = false;
                }
            } else {
                //var dir = transform.position.z <= 0.0f ? Vector3.left : Vector3.right;
                //dir.y = upMagnitude;
                transform.Translate(direction * finishSpeed * Time.deltaTime);
            }

            if (dropCounter < dropLimit) {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow)) {
                    Instantiate(kasaProto, kasaStack[dropCounter].transform.position, Quaternion.identity);
                    kasaStack[dropCounter].GetComponent<MarisaJizouMarisaKasaEffect>().DropEffect();
                    kasaStack[dropCounter].SetActive(false);
                    dropCounter++;
                }
            }
        }

        private void OnDestroy() {
            onTurning = null;
        }
    }
}