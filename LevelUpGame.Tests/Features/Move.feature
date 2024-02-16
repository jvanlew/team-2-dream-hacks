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
        | BottomRightDown   | 9                 | 0                 | South     | 84                | 9               | 0               | 85              |
        | BottomRightRight  | 9                 | 0                 | East      | 67                | 9               | 0               | 68              |
        | TopRightUp        | 9                 | 9                 | North     | 29                | 9               | 9               | 30              |
        | TopRightRight     | 9                 | 9                 | East      | 98                | 9               | 9               | 99              |
        | TopLeftTop        | 0                 | 9                 | North     | 62                | 0               | 9               | 63              |
        | TopLeftLeft       | 0                 | 9                 | West      | 31                | 0               | 9               | 32              |
        | BottomLeftLeft    | 0                 | 0                 | West      | 36                | 0               | 0               | 37              |
        | BottomLeftDown    | 0                 | 0                 | South     | 75                | 0               | 0               | 76              |
        | BottomWall        | 5                 | 0                 | South     | 71                | 5               | 0               | 72              |
        | LeftWall          | 0                 | 5                 | West      | 66                | 0               | 5               | 67              |
        | RightWall         | 9                 | 5                 | East      | 38                | 9               | 5               | 39              |
        | TopWall           | 5                 | 9                 | North     | 10                | 5               | 9               | 11              |
        | Marge             | 3                 | 4                 | North     | 57                | 3               | 5               | 58              |
        | Bart              | 5                 | 7                 | West      | 93                | 4               | 7               | 94              |
        | Lisa              | 7                 | 2                 | East      | 2                 | 8               | 2               | 3               |
        | Homer             | 6                 | 8                 | South     | 36                | 6               | 7               | 37              |
        | George Jetson     | 4                 | 3                 | North     | 6                 | 4               | 4               | 7               |
