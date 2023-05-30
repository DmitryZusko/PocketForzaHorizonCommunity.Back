import { Card, CardContent, CardMedia, Container, Skeleton, Typography } from "@mui/material";
import { styles } from "./styles";

const CardSkeletonComponent = () => {
  return (
    <Card sx={styles.skeleton}>
      <CardMedia>
        <Skeleton variant="rectangular" width="100vw" height={150} />
      </CardMedia>
      <CardContent>
        <Container>
          <Typography variant="textTitle">
            <Skeleton variant="text" />
          </Typography>
          <Typography variant="textBody">
            <Skeleton variant="text" />
          </Typography>
          <Typography variant="textBody">
            <Skeleton variant="text" />
          </Typography>
          <Typography variant="textBody">
            <Skeleton variant="text" width="60%" />
          </Typography>
        </Container>
      </CardContent>
    </Card>
  );
};

export default CardSkeletonComponent;
