using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private Image _enemyImage;
    [SerializeField] private Canvas _enemiesView;
    [SerializeField] private TextMeshProUGUI _countBulletsView;
    
    
    private int _enemiesCount;
    private Stack<Image> _enemyIcons;
    private int _countBullets;

    public void Initialize(int enemiesCount, int countBullets)
    {
        _enemiesCount = enemiesCount;
        _countBullets = countBullets;
    }
    
    public void DestroyEnemyIcon()
    {
        Destroy(_enemyIcons.Pop());
    }

    public void SetCountsBullets(int countBullets)
    {
        _countBulletsView.text = countBullets.ToString();
    }
    
    private void Start()
    {
        _enemyIcons = new Stack<Image>();
        
        for (var i = 0; i < _enemiesCount; i++)
        {
            var icon = Instantiate(_enemyImage, _enemiesView.transform);
            _enemyIcons.Push(icon);
        }
        
        _countBulletsView.text = _countBullets.ToString();
    }
    
}
