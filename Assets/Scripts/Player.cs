using UnityEngine;
using System;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Jetpack _jetpack;
    private Animator _anim;


    #endregion

    #region Unity Callbacks
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _anim.SetBool("Flying", _jetpack.Flying);

        ///Animation flying left/right//
        float Horizontal = Input.GetAxis("Horizontal");
        bool left = Horizontal < -0.1f;
        bool right = Horizontal > 0.1f;
        _anim.SetBool("isMovingLeft", left);
        _anim.SetBool("isMovingRight", right);

        if (left)
        {
            _jetpack.FlyHorizontal(Jetpack.Direction.Left);
        }
        else if (right)
        {
            _jetpack.FlyHorizontal(Jetpack.Direction.Right);
        }



        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
