using UnityEngine;

public class Bullet : MonoBehaviour
{
    private ScreenManager _screenManager;

    public void SetManager(ScreenManager screenManager)
    {
        _screenManager = screenManager;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(GlobalConstants.ENEMY_TAG))
        {
            Destroy(collision.gameObject);
            _screenManager.DestroyEnemyIcon();
        }
        
        Destroy(gameObject);
    }
}
