﻿namespace SWSniff.Core.Packets
{
    public enum PacketType : ushort
    {
        ClientSystemTutorialStage = 0x0114,
        ClientTradePassword = 0x0118,

        ClientLoginReq = 0x0201,
        ClientServerListReq = 0x0203,
        ClientServerConnectReq = 0x0205,
        ClientLoginForGf = 0x0224,
        ClientMobileAuth = 0x0233,
        ClientEnterServerReq = 0x0213,
        ClientEnterWaitCancel = 0x0235,

        ClientCreateCharacterReq = 0x0301,
        ClientDeleteCharacterReq = 0x0302,
        ClientCharacterChangeSlot = 0x0306,
        ClientCharacterListReq = 0x0311,
        ClientSelectCharacterReq = 0x0313,
        ClientSecondPassword = 0x0317,
        ClientEnterGameserverReq = 0x0321,
        ClientCharacterLoadTitle = 0x0323,
        ClientCharacterUpdateTitle = 0x0325,
        ClientCharacterInfoReq = 0x0331,
        ClientCharacterCheckEnterMaze = 0x0340,
        ClientCharacterUpdateSpecialOptionList = 0x0347,
        ClientCharaterChangeServer = 0x0360,
        ClientCharacterGetRewardSharePoint = 0x0363,
        ClientAchieveReward = 0x0371,
        ClientOtherCharacterInfo = 0x0375,
        ClientCharacterCommunity = 0x0377,

        ClientMazeCreateReq = 0x0441,

        ClientMovementMove = 0x0501,    //guessed name
        ClientMovementStop = 0x0503,    //guessed name
        ClientMovementJump = 0x0505,    //guessed name

        ClientChatSend = 0x0701,        //guessed name

        ClientItemInvenInfo = 0x0801,
        ClientItemMove = 0x0802,        //guessed name
        ClientItemJoinStack = 0x0803,   //guessed name
        ClientItemSplitStack = 0x0804,  //guessed name
        ClientItemMoveMoney = 0x0824,
        ClientItemSort = 0x0825,        //guessed name
        ClientItemUpdateQuickslotItem = 0x0828,
        ClientItemUpdateCash = 0x0833,
        ClientItemMazeRewardItem = 0x0847,
        ClientItemAppearanceEquip = 0x0852,
        ClientItemNameChange = 0x0853,

        ClientShopBuyItem = 0x0901,     //guessed name
        ClientShopSellItem = 0x0902,    //guessed name
        ClientShopCashLoad = 0x0920,
        ClientShopCashBuy = 0x0921,
        ClientShopCashSet = 0x0923,
        ClientShopCashSetDel = 0x0924,
        ClientShopCashGift = 0x0925,
        ClientShopGacha = 0x0926,
        ClientShopGetURL = 0x0932,
        ClientShopCashClose = 0x0933,

        ClientCompleteMazeReq = 0x1122,
        ClientCompleteMazeStartGame = 0x1125,
        ClientEventSpawnBox = 0x1131,
        ClientEventSceneDirecting = 0x1133,
        ClientCheckEventSpawnBoxReq = 0x1135,
        ClientMazeEnterPartyRes = 0x1148,
        ClientCheckEventSpawnBoxReq2 = 0x114C,
        ClientOperationEndReq = 0x1162,
        ClientQuestMoveCheckReq = 0x1165,
        ClientMonsterClientSpawn = 0x1171,
        ClientMazeSwitchNpcClickReq = 0x117C,
        ClientMazeLuaFunctionReq = 0x117E,

        ClientPartyMatchingEnter = 0x1230,
        ClientPartyMatchingExit = 0x1231,
        ClientPartyMatchingCheck = 0x1232,
        ClientPartyRecruitList = 0x1236,
        ClientPartyRecruitAdd = 0x1237,
        ClientPartyRecruitApply = 0x1238,
        ClientPartyRecruitApplyAccept = 0x1239,
        ClientPartyRecruitApplyReject = 0x123A,
        ClientPartyRecruitDel = 0x123C,
        ClientPartyRecruitApplyList = 0x123D,
        ClientPartyAwaiterAdd = 0x1240,
        ClientPartyAwaiterDel = 0x1241,
        ClientPartyAwaiterList = 0x1242,
        ClientPartyRecruitApplyInfo = 0x1243,
        ClientPartyAwaiterInfo = 0x1244,

        ClientDropPickUp = 0x1402,

        ClientQuestAccept = 0x1503,
        ClientQuestEpisodeComplete = 0x1505,
        ClientQuestGiveUp = 0x1506,
        ClientQuestEventUpdate = 0x1508,
        ClientQuestHelper = 0x1509,
        ClientQuestFail = 0x1511,

        ClientItemMake = 0x1801,
        ClientItemUpgrade = 0x1802,
        ClientItemExchange = 0x1803,
        ClientItemDisassemble = 0x1804,
        ClientItemSocketEquip = 0x1805,
        ClientItemSocketActive = 0x1806,
        ClientItemSocketDetach = 0x1807,
        ClientItemEvolution = 0x1813,
        ClientItemBroachEquip = 0x1820,
        ClientItemBroachActive = 0x1821,
        ClientItemRestore = 0x1822,
        ClientItemBroachCompose = 0x1823,
        ClientItemUnseal = 0x1824,
        ClientItemUseEffect = 0x1826,
        ClientItemBroachRemove = 0x1828,
        ClientItemSocketExchange = 0x1830,
        ClientItemSocketUpgrade = 0x1831,
        ClientItemSocketExtract = 0x1832,

        ClientFriendInvite = 0x1911,
        ClientFriendInviteAccept = 0x1913,
        ClientFriendDelete = 0x1915,
        ClientFriendBlockAdd = 0x1921,
        ClientFriendBlockDel = 0x1922,
        ClientFriendInfo = 0x1932,
        ClientFriendFind = 0x1933,
        ClientFriendRecruitList = 0x1941,
        ClientFriendRecruitAdd = 0x1942,
        ClientFriendRecruitDel = 0x1943,
        ClientFriendRecruitInfo = 0x1944,
        ClientFriendRecommandList = 0x1951,

        ClientPostSendList = 0x2001,
        ClientPostRecvList = 0x2002,
        ClientPostSend = 0x2003,
        ClientPostRead = 0x2004,
        ClientPostReceipt = 0x2005,
        ClientPostRecvDel = 0x2007,
        ClientPostSendDel = 0x2006,
        ClientPostSendback = 0x2008,
        ClientPostSave = 0x2012,
        ClientPostSaveList = 0x2013,
        ClientPostAccountList = 0x2014,
        ClientPostAccountRead = 0x2016,
        ClientPostAccountReceipt = 0x2017,
        ClientPostRecvDel2 = 0x2018,
        ClientPostRecvDel3 = 0x2019,
        ClientPostReceiptAll = 0x2020,
        ClientPostListRefresh = 0x2021,
        ClientSoulmetryComplete = 0x2105,

        ClientLeagueCreate = 0x2201,
        ClientLeagueDelete = 0x2202,
        ClientLeagueList = 0x2203,
        ClientLeagueApplicant = 0x2205,
        ClientLeagueBoard = 0x2208,
        ClientLeagueWithdraw = 0x2209,
        ClientLeagueDelegate = 0x220A,
        ClientLeagueKick = 0x220F,
        ClientLeagueInvite = 0x2213,
        ClientLeagueInviteAccept = 0x2214,
        ClientLeagueInviteReject = 0x2215,
        ClientLeagueApplicantAccept = 0x2218,
        ClientLeagueApplicantReject = 0x2219,
        ClientLeagueSearch = 0x2220,
        ClientLeagueOverlapName = 0x2221,
        ClientLeagueNoticeChange = 0x2229,
        ClientLeagueNameChange = 0x2230,
        ClientLeagueCardChange = 0x2231,
        ClientLeagueAuthChange = 0x2232,
        ClientLeaguePositionNameChange = 0x2233,
        ClientLeagueMemberPositionChange = 0x2239,
        ClientLeagueOpenORNot = 0x2246,
        ClientLeagueRecruitNotice = 0x2247,
        ClientLeagueSkillLearn = 0x2253,
        ClientLeagueInventoryMove = 0x2254,
        ClientLeagueInventoryInfo = 0x2256,

        ClientDailyMissionAccept = 0x2402,
        ClientDailyMissionHelper = 0x2404,

        ClientVaccumClickStart = 0x2501,
        ClientVaccumClickCancel = 0x2502,

        ClientMyroomEditStart = 0x2605,
        ClientMyroomEditEnd = 0x2606,
        ClientMyroomCreateReq = 0x2610,
        ClientMyroomEnterReq = 0x2611,
        ClientMyroomExitReq = 0x2613,
        ClientMyroomSetup = 0x2614,
        ClientMyroomKickOut = 0x2615,
        ClientMyroomDoorState = 0x2626,
        ClientMyroomPollenAdd = 0x2631,
        ClientMyroomPollenCultivation = 0x2632,
        ClientMyroomPollenHarvest = 0x2633,
        ClientMyroomPollenHelp = 0x2634,
        ClientMyroomPollenItemUse = 0x2635,
        ClientMyroomPlllenCancel = 0x2637,
        ClientMyroomPlllenCancel2 = 0x2638,
        ClientMyroomRecommend = 0x2640,
        ClientMyroomFavorite = 0x2641,
        ClientMyroomWriteBoard = 0x2642,
        ClientMyroomWriteInfo = 0x2643,
        ClientMyroomBoardList = 0x2644,
        ClientMyroomRankInfo = 0x2646,
        ClientMyroomFavoriteInfo = 0x2647,
        ClientMyroomRankReward = 0x2648,

        ClientHelperSummon = 0x2702,
        ClientHelperSupportInfo = 0x2705,
        ClientHelperSupportRegister = 0x2706,
        ClientHelperSupportReward = 0x2707,
        ClientHelperSupportList = 0x2708,
        ClientHelperSupportEquip = 0x2709,
        ClientHelperEquip = 0x2710,
        ClientHelperChangeOrder = 0x2712,
        ClientHelperAllRelease = 0x2714,
        ClientHelperAutoSummon = 0x2715,

        ClientInfiniteTowerEnterChapter = 0x2802,
        ClientInfiniteTowerEnterNextStage = 0x2803,

        ClientEventAttendanceReward = 0x2A02,
        ClientEventAttendancePlayTimeReward = 0x2A05,
        ClientEventUseCouponCode = 0x2A22,

        ClientExchangeSearch = 0x2B01,
        ClientExchangePriceHistory = 0x2B02,
        ClientExchangeInterestList = 0x2B03,
        ClientExchangeInterestItem = 0x2B04,
        ClientExchangeSellRegister = 0x2B05,
        ClientExchangeItemBuy = 0x2B06,
        ClientExchangeItemRecall = 0x2B07,
        ClientExchangeMyList = 0x2B08,

        ClientRankingTimeAttackList = 0x2C01,
        ClientRankingPvpList = 0x2C02,
        ClientRankingInfiniteTowerList = 0x2C03,

        ClientSocialItemStart = 0x2D01,
        ClientSocialItemStop = 0x2D03,
        ClientSocialItemUse = 0x2D02,

        ClientForceInvite = 0x2E01,
        ClientForceAccept = 0x2E02,
        ClientForceChangeMaster = 0x2E03,
        ClientForceKickOut = 0x2E04,
        ClientForceLeave = 0x2E05,
        ClientForceCancel = 0x2E08,
        ClientForceMatchingEnter = 0x2E30,
        ClientForceMatchingExit = 0x2E31,
        ClientForceMatchingCheck = 0x2E32,

        ClientWeeklyMissionReward = 0x3203,
        ClientWeeklyMissionRewardWeek = 0x3204,
        ClientModeMazeMatchingEnter = 0x3301,
        ClientModeMazeMatchingExit = 0x3303,
        ClientModeMazeMatchingCheck = 0x3304,
        ClientModeMazeRankingList = 0x3321,
        ClientModeMazeRankingReward = 0x3322,

        ClientChannelInfo = 0xF101,
    }
}
