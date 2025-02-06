CREATE PROCEDURE [GetQuestInfoById] @QuestId INT

AS BEGIN

SELECT * FROM Quest WHERE Quest_Id = @QuestId;

SELECT * FROM Quest_Monsters WHERE Quest_Id = @QuestId

SELECT * FROM Quest_Rewards WHERE Quest_Id = @QuestId

END