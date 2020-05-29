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
  subscribeToNewBookReviews(): void;
}

export const BookReviewList: React.FC<IBookReviewListProps> = ({
  data,
  subscribeToNewBookReviews,
}) => {
  subscribeToNewBookReviews();

  const renderItem = (item: IBookReviewListItem, index: number) => {
    const avatarHash = item.name.split(' ').join('');

    return (
      <Feed.Event key={`book_review_${index}`}>
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
          <Feed.Extra text={true}>
            {item.content.split('\n').map((line, i) => (
              <p key={`book_review_content_${index}_${i}`}>
                {line || '\u00a0'}
              </p>
            ))}
          </Feed.Extra>
        </Feed.Content>
      </Feed.Event>
    );
  };

  return <Feed>{data.map(renderItem)}</Feed>;
};
