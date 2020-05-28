import moment from 'moment';
import React from 'react';
import { Feed, Image } from 'semantic-ui-react';

export interface IBookReviewListItem {
  name: string;
  title: string;
  content: string;
  createdAt: number;
}

export interface IBookReviewListProps {
  data: IBookReviewListItem[];
}

export const BookReviewList: React.FC<IBookReviewListProps> = ({ data }) => {
  const renderItem = (item: IBookReviewListItem) => {
    const avatarHash = item.name.split(' ').join('');

    return (
      <Feed.Event>
        <Feed.Label>
          <Image
            avatar={true}
            src={`https://robohash.org/${avatarHash}?set=set4&bgset=&size=64x64`}
          />
        </Feed.Label>
        <Feed.Content>
          <Feed.Summary>
            <a>{item.name}</a> <b>{item.title}</b>
            <Feed.Date>{moment(item.createdAt).fromNow()}</Feed.Date>
          </Feed.Summary>
          <Feed.Extra text={true}>{item.content}</Feed.Extra>
        </Feed.Content>
      </Feed.Event>
    );
  };

  return <Feed>{data.map(renderItem)}</Feed>;
};
