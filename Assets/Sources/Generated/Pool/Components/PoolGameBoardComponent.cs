//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class PoolContext {

    public PoolEntity gameBoardEntity { get { return GetGroup(PoolMatcher.GameBoard).GetSingleEntity(); } }
    public GameBoardComponent gameBoard { get { return gameBoardEntity.gameBoard; } }
    public bool hasGameBoard { get { return gameBoardEntity != null; } }

    public PoolEntity SetGameBoard(int newColumns, int newRows) {
        if (hasGameBoard) {
            throw new Entitas.EntitasException("Could not set GameBoard!\n" + this + " already has an entity with GameBoardComponent!",
                "You should check if the context already has a gameBoardEntity before setting it or use context.ReplaceGameBoard().");
        }
        var entity = CreateEntity();
        entity.AddGameBoard(newColumns, newRows);
        return entity;
    }

    public void ReplaceGameBoard(int newColumns, int newRows) {
        var entity = gameBoardEntity;
        if (entity == null) {
            entity = SetGameBoard(newColumns, newRows);
        } else {
            entity.ReplaceGameBoard(newColumns, newRows);
        }
    }

    public void RemoveGameBoard() {
        gameBoardEntity.Destroy();
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

    public GameBoardComponent gameBoard { get { return (GameBoardComponent)GetComponent(PoolComponentsLookup.GameBoard); } }
    public bool hasGameBoard { get { return HasComponent(PoolComponentsLookup.GameBoard); } }

    public void AddGameBoard(int newColumns, int newRows) {
        var index = PoolComponentsLookup.GameBoard;
        var component = CreateComponent<GameBoardComponent>(index);
        component.columns = newColumns;
        component.rows = newRows;
        AddComponent(index, component);
    }

    public void ReplaceGameBoard(int newColumns, int newRows) {
        var index = PoolComponentsLookup.GameBoard;
        var component = CreateComponent<GameBoardComponent>(index);
        component.columns = newColumns;
        component.rows = newRows;
        ReplaceComponent(index, component);
    }

    public void RemoveGameBoard() {
        RemoveComponent(PoolComponentsLookup.GameBoard);
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

    static Entitas.IMatcher<PoolEntity> _matcherGameBoard;

    public static Entitas.IMatcher<PoolEntity> GameBoard {
        get {
            if (_matcherGameBoard == null) {
                var matcher = (Entitas.Matcher<PoolEntity>)Entitas.Matcher<PoolEntity>.AllOf(PoolComponentsLookup.GameBoard);
                matcher.componentNames = PoolComponentsLookup.componentNames;
                _matcherGameBoard = matcher;
            }

            return _matcherGameBoard;
        }
    }
}