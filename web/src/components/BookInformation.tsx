import React from 'react';
import { Divider, Grid, Header, Image } from 'semantic-ui-react';

export interface IBookInformationProps {
  name: string;
  imageUrl: string;
  description: string;
  author: {
    name: string;
  };
}

export const BookInformation: React.FC<IBookInformationProps> = ({
  name,
  imageUrl,
  description,
  author,
}) => {
  return (
    <div>
      <Header size="huge">
        {name}
        <Header.Subheader>{author.name}</Header.Subheader>
      </Header>
      <Divider />
      <Grid>
        <Grid.Row>
          <Grid.Column width="5">
            <Image src={imageUrl} />
          </Grid.Column>
          <Grid.Column width="9">
            <div dangerouslySetInnerHTML={{ __html: description }} />
          </Grid.Column>
        </Grid.Row>
      </Grid>
    </div>
  );
};
