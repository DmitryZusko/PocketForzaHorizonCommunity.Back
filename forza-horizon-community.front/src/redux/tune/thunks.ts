import tuneService from "@/services/tune-service";
import { createAsyncThunk } from "@reduxjs/toolkit";

export const getLatestTunes = createAsyncThunk("tune/getLatestTunes", async (amount: number) => {
  return tuneService.getLatestTunes(amount);
});