//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public NestedViewContainerComponent nestedViewContainer { get { return (NestedViewContainerComponent)GetComponent(ComponentIds.NestedViewContainer); } }

        public bool hasNestedViewContainer { get { return HasComponent(ComponentIds.NestedViewContainer); } }

        public Entity AddNestedViewContainer(System.Collections.Generic.IDictionary<string, UnityEngine.Transform> newValue) {
            var component = CreateComponent<NestedViewContainerComponent>(ComponentIds.NestedViewContainer);
            component.value = newValue;
            return AddComponent(ComponentIds.NestedViewContainer, component);
        }

        public Entity ReplaceNestedViewContainer(System.Collections.Generic.IDictionary<string, UnityEngine.Transform> newValue) {
            var component = CreateComponent<NestedViewContainerComponent>(ComponentIds.NestedViewContainer);
            component.value = newValue;
            ReplaceComponent(ComponentIds.NestedViewContainer, component);
            return this;
        }

        public Entity RemoveNestedViewContainer() {
            return RemoveComponent(ComponentIds.NestedViewContainer);
        }
    }

    public partial class Pool {
        public Entity nestedViewContainerEntity { get { return GetGroup(Matcher.NestedViewContainer).GetSingleEntity(); } }

        public NestedViewContainerComponent nestedViewContainer { get { return nestedViewContainerEntity.nestedViewContainer; } }

        public bool hasNestedViewContainer { get { return nestedViewContainerEntity != null; } }

        public Entity SetNestedViewContainer(System.Collections.Generic.IDictionary<string, UnityEngine.Transform> newValue) {
            if (hasNestedViewContainer) {
                throw new EntitasException("Could not set nestedViewContainer!\n" + this + " already has an entity with NestedViewContainerComponent!",
                    "You should check if the pool already has a nestedViewContainerEntity before setting it or use pool.ReplaceNestedViewContainer().");
            }
            var entity = CreateEntity();
            entity.AddNestedViewContainer(newValue);
            return entity;
        }

        public Entity ReplaceNestedViewContainer(System.Collections.Generic.IDictionary<string, UnityEngine.Transform> newValue) {
            var entity = nestedViewContainerEntity;
            if (entity == null) {
                entity = SetNestedViewContainer(newValue);
            } else {
                entity.ReplaceNestedViewContainer(newValue);
            }

            return entity;
        }

        public void RemoveNestedViewContainer() {
            DestroyEntity(nestedViewContainerEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherNestedViewContainer;

        public static IMatcher NestedViewContainer {
            get {
                if (_matcherNestedViewContainer == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.NestedViewContainer);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherNestedViewContainer = matcher;
                }

                return _matcherNestedViewContainer;
            }
        }
    }
}
