//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PoolContext {

    public PoolEntity gameOverEntity { get { return GetGroup(PoolMatcher.GameOver).GetSingleEntity(); } }

    public bool isGameOver {
        get { return gameOverEntity != null; }
        set {
            var entity = gameOverEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isGameOver = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PoolEntity {

    static readonly GameOverComponent gameOverComponent = new GameOverComponent();

    public bool isGameOver {
        get { return HasComponent(PoolComponentsLookup.GameOver); }
        set {
            if (value != isGameOver) {
                if (value) {
                    AddComponent(PoolComponentsLookup.GameOver, gameOverComponent);
                } else {
                    RemoveComponent(PoolComponentsLookup.GameOver);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class PoolMatcher {

    static Entitas.IMatcher<PoolEntity> _matcherGameOver;

    public static Entitas.IMatcher<PoolEntity> GameOver {
        get {
            if (_matcherGameOver == null) {
                var matcher = (Entitas.Matcher<PoolEntity>)Entitas.Matcher<PoolEntity>.AllOf(PoolComponentsLookup.GameOver);
                matcher.componentNames = PoolComponentsLookup.componentNames;
                _matcherGameOver = matcher;
            }

            return _matcherGameOver;
        }
    }
}
