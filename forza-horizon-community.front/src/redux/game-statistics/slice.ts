import { createSlice } from "@reduxjs/toolkit";
import { IGameStatisticsState } from "../types";
import { getAchievementStats, getCurrentOnline } from "./thunks";

const initialState: IGameStatisticsState = {
  isLoadingPlayersNumber: false,
  totalPlayers: 0,
  isLoadingAchievements: false,
  achievements: [],
};

const gameStatisticsSlice = createSlice({
  name: "gameStatistics",
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(getAchievementStats.pending, (state) => {
      state.isLoadingAchievements = true;
    });
    builder.addCase(getCurrentOnline.pending, (state) => {
      state.isLoadingPlayersNumber = true;
    });
    builder.addCase(getAchievementStats.fulfilled, (state, { payload }) => {
      state.achievements = payload.data;
      state.isLoadingAchievements = false;
    });
    builder.addCase(getCurrentOnline.fulfilled, (state, { payload }) => {
      state.totalPlayers = payload.data;
      state.isLoadingPlayersNumber = false;
    });
    builder.addCase(getAchievementStats.rejected, (state) => {
      state.isLoadingAchievements = false;
    });
    builder.addCase(getCurrentOnline.rejected, (state) => {
      state.isLoadingPlayersNumber = false;
    });
  },
});

export default gameStatisticsSlice.reducer;