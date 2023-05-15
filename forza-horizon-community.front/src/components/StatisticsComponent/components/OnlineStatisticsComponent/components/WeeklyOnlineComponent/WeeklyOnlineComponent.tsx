import { baseTheme } from "@/components/constants";
import { Container, Typography } from "@mui/material";
import { Bar, BarChart, Tooltip, XAxis } from "recharts";
import { CustomBarTooltipComponent } from "./components";
import { styles } from "./styles";
import { IWeeklyOnlineComponentProps } from "./types";
import { useWeeklyOnlineComponent } from "./useWeeklyOnlineComponent";

const WeeklyOnlineComponent = ({ totalPlayers, ...props }: IWeeklyOnlineComponentProps) => {
  const { getFakeWeeklyOnline } = useWeeklyOnlineComponent({ totalPlayers });

  return (
    <Container sx={styles.outerContainer} {...props}>
      <Typography variant="textTitle">Wheekly-Avarage Online</Typography>
      <BarChart width={400} height={400} data={getFakeWeeklyOnline}>
        <Bar dataKey={"onlineCount"} fill={baseTheme.palette.primary.main} />
        <XAxis dataKey={"date"} fontFamily={"Urbanist"} interval={0} />
        <Tooltip content={<CustomBarTooltipComponent />} />
      </BarChart>
    </Container>
  );
};

export default WeeklyOnlineComponent;
