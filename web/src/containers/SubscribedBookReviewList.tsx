import { useSubscription } from '@apollo/react-hooks';
import React, { useEffect, useState } from 'react';
import { BookReviewList, IBookReviewListProps } from '../components';
import { ON_BOOK_REVIEW_ADDED } from '../graphql/subscriptions';

export interface ISubscribedBookReviewListProps extends IBookReviewListProps {
  bookId: number;
}

function withSubscription<T extends ISubscribedBookReviewListProps>(
  Component: React.ComponentType<T>
) {
  return (props: T) => {
    const [reviews, setReviews] = useState(props.data);
    const { loading, data } = useSubscription(ON_BOOK_REVIEW_ADDED, {
      variables: {
        bookId: props.bookId,
      },
      onSubscriptionData: e => console.log(e),
    });

    return <Component {...props} data={reviews} />;
  };
}

export const SubscribedBookReviewList = withSubscription(BookReviewList);
