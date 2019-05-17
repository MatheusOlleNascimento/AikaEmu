namespace AikaEmu.GameServer.Network
{
    public enum GameOpcode : ushort
    {
        SendFriendInfo = 0x870,
        DespawnUnit = 0x1001,
        UpdateWithSkillEffect = 0x1002,
        UpdateHpMp = 0x1003,
        UseEmoticon = 0x3004,
        NpcStoreOpen = 0x1006,
        UpdateSkills = 0x1007,
        UpdateExperience = 0x1008,
        UpdateAttributes = 0x1009,
        UpdateStatus = 0x100A,
        SetEffectOnHead = 0x100D,
        OpenNpcChat = 0x100E,
        CloseNpcChat = 0x100F,
        ResetChatOptions = 0x1010,
        NpcStartTalk = 0x1011,
        SendNpcOption = 0x1012,
        PlaySound = 0x1015,
        UpdatePranExperience = 0x1016,
        PranEffect = 0x1017,
        SendXpGoldAnimation = 0x101B,
        UpdateEquipDur = 0x102B,
        CurNationInfo = 0x1028,
        UpdateNationGuild = 0x1030,
        UpdateReliques = 0x1036,
        UpdateBank = 0x1037,
        UpdatePremiumStash = 0x1038,
        UpdateCash = 0x1039,
        UpdateAccountLevel = 0x104F,
        SendXpMessage = 0x1053,
        ApplyBuff = 0x106F,
        UpdateBuffs = 0x1070,
        UpdateTitleList = 0x107D,
        SendCharacterList = 0x1801,
        SendPranToWorld = 0x1807,
        UpdateSiegeInfo = 0x181A,
        SendToWorld = 0x1825,
        UpdateNationGovernment = 0x1836,
        UpdateDungeonTimer = 0x184C,
        UpdateNationReliques = 0x1853,
        SendGuildInfo = 0x1865,
        SendInviteToGuild = 0x187C,
        SendGuildMembers = 0x187F,
        SendMessage = 0x1884,
        RenamePranResult = 0x2F02,
        OpenNpcShop = 0x3010,
        UpdateCharGold = 0x3012,
        SendTradeRequest = 0x3015,
        SendTradeResult = 0x3016,
        SendTradeData = 0x3017,
        SendCancelTrade = 0x3018,
        SendPersonalStore = 0x3019,
        UpdateSkillBar = 0x301E,
        SendCastSkill = 0x3020,
        SendPartyInvite = 0x3022,
        SendPartyInfo = 0x3026,
        SendEnchantResult = 0x302E,
        RemoveQuestInfo = 0x302F,
        SendQuestRewardChoice = 0x3030,
        SendQuestInfo = 0x3031,
        CreateGuildBox = 0x3041,
        SendUnitSpawn = 0x3049,
        SendMobSpawn = 0x305E,
        SendRequestFriend = 0x3072,
        CoreConversionResult = 0x308C,
        SendTokenResult = 0x309D,
        UpdatePosition = 0x30BF,
        UpdateItem = 0x3C0E,
        SendFriendChatMessage = 0x3C26,
        StartFriendChat = 0x3C27,
        RemoveFriend = 0x3C74,
        UpdateMapInfo = 0x3C79,
        SendChatMessage = 0x3C86,
        FinishedInGameState = 0x3CBE,
        ResponseDeleteCharToken = 0x3F33,
        UpdatePuzzleEvent = 0x3F34,

        Unk101F = 0x101F,
        Unk1027 = 0x1027,
        Unk102C = 0x102C,
        Unk1031 = 0x1031,
        Unk1054 = 0x1054,
        Unk107E = 0x107E, // Seems to be related to quest completion
        UnkTitleLink2 = 0x1086,
        Unk1C41 = 0x1C41,
        InitialUnk202 = 0x2027,
        Unk303D = 0x303D,
        Unk3057 = 0x3057,
        Unk30A2 = 0x30A2,
        Unk30A5 = 0x30A5,
        UnkTitleLink = 0x30A6,
        Unk3C7C = 0x3C7C,
        Unk3F1B = 0x3F1B,
        Unk3F34 = 0x3F34,
        Unk4756 = 0x4756,
    }

    public enum ClientOpcode : ushort
    {
        RequestUpdateCash = 0x200A,
        RequestDeleteChar = 0x2403,
        ReturnCharacterSelect = 0x2468,
        RequestEnterGame = 0x24C1,
        RequestFriendResult = 0x2473,
        AcceptGuildRequest = 0x247d,
        RenamePran = 0x2F02,
        CreateCharacter = 0x2F04,
        RequestUseEmoticon = 0x3004,
        RotationUnit = 0x3005,
        UnkClientRequest = 0x3006,
        RequestNpcChat = 0x300F,
        BuyFromNpcStore = 0x3013,
        RequestTrade = 0x3015,
        RequestTradeResult = 0x3016,
        UpdateTradeData = 0x3017,
        RequestCancelTrade = 0x3018,
        RequestOpenPlayerStore = 0x301A,
        BuySkillFromNpc = 0x301C,
        RequestUseItem = 0x301D,
        RequestUpdateSkillBar = 0x301E,
        CloseMyPersonalStore = 0x3018,
        OpenMyPersonalStore = 0x3019,
        RequestCastSkill = 0x3020,
        InviteToParty = 0x3022,
        InviteToPartyResult = 0x3023,
        LeaveParty = 0x3024,
        DisbandParty = 0x3025,
        RequestDeleteItem = 0x302C,
        RequestEnchant = 0x302D,
        QuestRewardChoice = 0x3030,
        RequestMergeItems = 0x3032,
        RequestSplitItem = 0x3033,
        RequestCreateGuild = 0x3041,
        InviteToRaid = 0x3042,
        NpcShopClosed = 0x3048,
        ChangePartyLeader = 0x304B,
        RequestCoreConversion = 0x308C,
        RequestTokenResult = 0x309D,
        MoveUnit = 0x30BF,
        RequestUseSkill = 0x30C0,
        SetActiveTitle = 0x3061,
        RequestAddFriend = 0x3072,
        MoveItem = 0x340F,
        RequestNationReliques = 0x3852,
        RequestToken = 0x3C02,
        FriendChatMessage = 0x3C26,
        RequestFriendChat = 0x3C27,
        RequestMoveGold = 0x3C59,
        RequestRemoveFriend = 0x3C74,
        RequestMapInfo = 0x3C79,
        RefuseGuildInvite = 0x3C7E,
        SendChatMessage = 0x3C86,
        InGameState = 0x3CBE,
        RequestDeleteCharToken = 0x3F33,
        PuzzleEventRequest = 0x3F34,
    }
}