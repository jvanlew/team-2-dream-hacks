Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction

    Given the character <CharacterName> starts at position with X-coordinates <startingPositionX>
    And starts at Y-coordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves
    Then the character is now at position with X-coordinates <endingPositionX>
    And Y-coordinates <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:
        | CharacterName     | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
        | BottomRightDown   | 9                 | 0                 | SOUTH     | 84                | 9               | 0               | 85              |
        | BottomRightRight  | 9                 | 0                 | EAST      | 67                | 9               | 0               | 68              |
        | TopRightUp        | 9                 | 9                 | NORTH     | 29                | 9               | 9               | 30              |
        | TopRightRight     | 9                 | 9                 | EAST      | 98                | 9               | 9               | 99              |
        | TopLeftTop        | 0                 | 9                 | NORTH     | 62                | 0               | 9               | 63              |
        | TopLeftLeft       | 0                 | 9                 | WEST      | 31                | 0               | 9               | 32              |
        | BottomLeftLeft    | 0                 | 0                 | WEST      | 36                | 0               | 0               | 37              |
        | BottomLeftDown    | 0                 | 0                 | SOUTH     | 75                | 0               | 0               | 76              |
        | BottomWall        | 5                 | 0                 | SOUTH     | 71                | 5               | 0               | 72              |
        | LeftWall          | 0                 | 5                 | WEST      | 66                | 0               | 5               | 67              |
        | RightWall         | 9                 | 5                 | EAST      | 38                | 9               | 5               | 39              |
        | TopWall           | 5                 | 9                 | NORTH     | 10                | 5               | 9               | 11              |
        | Marge             | 3                 | 4                 | NORTH     | 57                | 3               | 5               | 58              |
        | Bart              | 5                 | 7                 | WEST      | 93                | 6               | 7               | 94              |
        | Lisa              | 7                 | 2                 | EAST      | 2                 | 7               | 3               | 3               |
        | Homer             | 6                 | 8                 | SOUTH     | 36                | 6               | 7               | 37              |
        | George Jetson     | 4                 | 3                 | NORTH     | 6                 | 4               | 4               | 7               |
