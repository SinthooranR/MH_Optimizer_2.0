CREATE PROCEDURE GetMonsterDetailsByName
    @MonsterName NVARCHAR(100)
AS
BEGIN
    -- Monster Details
    SELECT * FROM Monster WHERE Name = @MonsterName;

    -- Ailments related to the monster
    SELECT * FROM Monster_Ailments WHERE Name = @MonsterName;

    -- Breaks related to the monster
    SELECT * FROM Monster_Breaks WHERE Name = @MonsterName;

    -- Hitzones related to the monster
    SELECT * FROM Monster_Hitzones WHERE Name = @MonsterName;

    -- Rewards related to the monster
    SELECT * FROM Monster_Rewards WHERE Name = @MonsterName;

    -- Weaknesses related to the monster
    SELECT * FROM Monster_Weaknesses WHERE Name = @MonsterName;

	-- Habitats related to the monster
    SELECT * FROM Monster_Habitats WHERE Name = @MonsterName;
END