﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles
{
    public class opencloseDoor : MonoBehaviour
    {
        public Animator openandclose;
        public bool open;
        public Transform Player;

        void Start()
        {
            open = false;
        }

        void OnMouseOver()
        {
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                Debug.Log("Distance to player: " + dist);
                if (dist < 200)
                {
                    if (open == false)
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            StartCoroutine(opening());
                        }
                    }
                    else
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            StartCoroutine(closing());
                        }
                    }

                }
            }
        }

        IEnumerator opening()
        {
            print("you are opening the door");
            openandclose.Play("Opening");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the door");
            openandclose.Play("Closing");
            open = false;
            yield return new WaitForSeconds(.5f);
        }
    }
}
