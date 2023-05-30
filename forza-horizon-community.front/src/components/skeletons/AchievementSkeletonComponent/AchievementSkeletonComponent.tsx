import { Container, Skeleton, Typography } from "@mui/material";

const AchievementSkeletonComponent = () => {
  return (
    <Container>
      <Skeleton variant="rectangular" width="100%" height={150} />
      <Typography variant="textTitle">
        <Skeleton variant="text" />
      </Typography>
      <Typography variant="textBody">
        <Skeleton variant="text" />
      </Typography>
    </Container>
  );
};

export default AchievementSkeletonComponent;
