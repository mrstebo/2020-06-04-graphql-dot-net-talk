import React from 'react';
import { Grid, Header, Image } from 'semantic-ui-react';

export interface IAuthorInformationProps {
  name: string;
  imageUrl: string;
}

export const AuthorInformation: React.FC<IAuthorInformationProps> = ({
  name,
  imageUrl,
}) => {
  return (
    <div>
      <Grid>
        <Grid.Row>
          <Grid.Column width="2">
            <Image src={imageUrl} />
          </Grid.Column>
          <Grid.Column width="10" verticalAlign="middle">
            <Header size="huge">{name}</Header>
          </Grid.Column>
        </Grid.Row>
      </Grid>
    </div>
  );
};
