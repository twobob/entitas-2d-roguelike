//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PoolEntity {

    public NestedViewComponent nestedView { get { return (NestedViewComponent)GetComponent(PoolComponentsLookup.NestedView); } }
    public bool hasNestedView { get { return HasComponent(PoolComponentsLookup.NestedView); } }

    public void AddNestedView(string newName) {
        var index = PoolComponentsLookup.NestedView;
        var component = CreateComponent<NestedViewComponent>(index);
        component.name = newName;
        AddComponent(index, component);
    }

    public void ReplaceNestedView(string newName) {
        var index = PoolComponentsLookup.NestedView;
        var component = CreateComponent<NestedViewComponent>(index);
        component.name = newName;
        ReplaceComponent(index, component);
    }

    public void RemoveNestedView() {
        RemoveComponent(PoolComponentsLookup.NestedView);
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

    static Entitas.IMatcher<PoolEntity> _matcherNestedView;

    public static Entitas.IMatcher<PoolEntity> NestedView {
        get {
            if (_matcherNestedView == null) {
                var matcher = (Entitas.Matcher<PoolEntity>)Entitas.Matcher<PoolEntity>.AllOf(PoolComponentsLookup.NestedView);
                matcher.componentNames = PoolComponentsLookup.componentNames;
                _matcherNestedView = matcher;
            }

            return _matcherNestedView;
        }
    }
}
